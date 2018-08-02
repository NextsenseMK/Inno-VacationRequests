var webpack = require('webpack');
const AngularCompilerPlugin = require('@ngtools/webpack').AngularCompilerPlugin;


module.exports = (env, args) => {
    return {
        devtool: 'source-map',
        entry: {
            app: './app/src/main.ts',
            vendor: './app/src/vendor.ts'
        },
        output: {
            path: __dirname + "/wwwroot/dist",
            filename: '[name].js'
        },
        module: {
            rules: [
                { test: /\.ts$/, loader: args.mode == 'production' ? ['@ngtools/webpack', 'angular2-template-loader'] : ['ts-loader', 'angular2-template-loader'] },
                { test: /\.html$/, loader: ['html-loader'] },
                { test: /\.css$/, loader: ['style-loader', 'css-loader'] }
            ]
        },
        resolve: {
            extensions: ['.js', '.ts', '.html', '.css']
        },
        plugins: args.mode == 'production' ? [
            new AngularCompilerPlugin({
                tsConfigPath: './tsconfig.json',
                entryModule: './app/src/app.module#AppModule',
                sourceMap: true
            })] : [],
        optimization: {
            splitChunks: {
                cacheGroups: {
                    commons: {
                        name: 'commons',
                        chunks: 'all',
                        minChunks: 2
                    }
                }
            }
        }
    }


}
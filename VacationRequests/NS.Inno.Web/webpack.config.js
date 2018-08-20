var webpack = require('webpack');


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
                { test: /\.ts$/,  loader:['ts-loader', 'angular2-template-loader'] },
                { test: /\.html$/, loader: ['html-loader'] },
                { test: /\.css$/, loader: ['style-loader','css-loader'] }
            ]
        },
        resolve: {
            extensions: ['.js', '.ts', '.html', '.css']
        },
        plugins:[],
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
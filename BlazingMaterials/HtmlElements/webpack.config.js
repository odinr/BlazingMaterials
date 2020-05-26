var path = require("path");

module.exports = {
  mode: "production",
  entry: "./src/index.ts",
  output: {
    library: ["BlazingMaterials"],
    libraryTarget: 'window',
    filename: "index.js",
    path: path.resolve(__dirname, "..", "wwwroot"),
    chunkFilename: "[name].js",
    publicPath: "/_content/BlazingMaterials/"
  },
  module: {
    rules: [
      {
        test: /\.ts$/,
        use: [
          {
            loader: "ts-loader",
            options: {
              compilerOptions: {
                noEmit: false
              }
            }
          }
        ],
        exclude: /node_modules/
      },
      // {
      //   test: require.resolve("./src/shims.js"),
      //   use: "exports-loader?file,BlazingMaterial=>BlazingMaterial"
      // }
    ]
  },
  resolve: {
    extensions: [".ts", ".js"]
  }
};

const bodyParser = require("body-parser");
const express= require("express");
const app=express();
const shelljs =require("shelljs")
var port=8000;

app.get('/', (req, res) => {
    
    var output =shelljs.exec('curl -H "Accept: application/vnd.github.v3+json" -u vinothkumarGanesan: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 https://api.github.com/repos/TestingGitVinoth/DotNetPipeline/commits/8d023cff49b19626003c3cbc761bc2e793aef772')
    //console.log(output);
    //res.send("as it was")
     res.send(output)
  })

app.listen(port, function(err){
    if (err) 
    {
        console.log(err);
        console.log("Server listening on PORT", port);
    }
}); 

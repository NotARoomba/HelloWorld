console.log("l")
const { exec } = require("child_process")
exec("python d.py", (error, stdout, stderr) => {
    console.log(stdout)
});
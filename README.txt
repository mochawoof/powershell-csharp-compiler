v1.1
made by PUP! U^w^U

compiler.ps1 compiles and runs your C# code in native Powershell!

---
it can be configured by the .config file:

source: path of your C# source file, can be relative or absolute
namespace: the namespace corresponding to your source file, make sure this is right!
class: the name of the class where your Main method is in your source file
args: the arguments passed to your Main method, using Powershell syntax

---
you can also pass arguments to the script instead of a config file like this:

./compiler.ps1 source namespace class args
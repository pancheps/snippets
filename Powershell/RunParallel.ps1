$executable = "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow\VsTest\vstest.console.exe"
$testsBinary =  ,"C:\Users\Pancho\source\repos\ParalellTestProject\ParalellTestProject\bin\Release\net6.0\ParalellTestProject.dll"
$testMethods = '/Tests:TestMethod1,TestMethod7', '/Tests:TestMethod2', '/Tests:TestMethod3', '/Tests:TestMethod4', '/Tests:TestMethod5', '/Tests:TestMethod6'
$testMethods | Foreach-Object -ThrottleLimit 5 -Parallel {
    $parameters = $USING:testsBinary, $_
    & $USING:executable $parameters
}
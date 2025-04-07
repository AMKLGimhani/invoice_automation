Dim commitMessage As String = "feat: create MySQL database schema for invoice storage" & vbCrLf & _
    "Design and build a relational schema for storing invoice data."

Dim gitCommand As New Process
gitCommand.StartInfo.FileName = "cmd.exe"
gitCommand.StartInfo.Arguments = "/c git commit -m """ & commitMessage.Replace("""", "\""") & """"
gitCommand.StartInfo.WorkingDirectory = "C:\Path\To\Your\Git\Repository" ' <-- Change this to your Git repo path
gitCommand.StartInfo.RedirectStandardOutput = True
gitCommand.StartInfo.RedirectStandardError = True
gitCommand.StartInfo.UseShellExecute = False
gitCommand.StartInfo.CreateNoWindow = True

gitCommand.Start()
gitCommand.WaitForExit()

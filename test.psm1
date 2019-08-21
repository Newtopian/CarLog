function Get-SomeInfo {
      [CmdletBinding()]
    param();

    begin {}

    process {
      get-childitem env:
      Get-ExecutionPolicy -list
    }
    end {}
}

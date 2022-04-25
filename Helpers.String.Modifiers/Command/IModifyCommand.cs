namespace DesignPatterns.Command
{
    public interface IModifyCommand
    {
        string Execute(string source);
    }
}

namespace CooCoo
{
    public static class Brain
    {
        public static string Topic { get; set; }
        public static CommandBase PreviousCommand { get; set; }
        public static State State { get; set; }
    }
}

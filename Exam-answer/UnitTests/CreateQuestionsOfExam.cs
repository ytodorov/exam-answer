using System.IO;

namespace UnitTests
{
    public class CreateQuestionsOfExam
    {
        // [Fact]
        public void RecordCrt251VideoTest()
        {
            string text = File.ReadAllText("Q1.txt");
            for (int i = 2; i < 100; i++)
            {
                string newText = text.Replace("Q1Instance", $"Q{i}Instance").Replace("Order = 1", $"Order = {i}");
                File.WriteAllText($"Q{i}.cs", newText);
            }
        }
    }
}
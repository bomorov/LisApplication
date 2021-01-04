using System.Collections.Generic;
using System.Linq;

namespace Application.Common.Models
{
    public class Result
    {
        public Result(bool succeeded, string title, string type, IEnumerable<string> messages)
        {
            Succeeded = succeeded;
            AlertTitle = title;
            AlertType = type;
            Messages = messages.ToArray();
        }

        public bool Succeeded { get; set; }
        public string AlertType { get; set; }
        public string AlertTitle { get; set; }
        public string[] Messages { get; set; }

        public static Result Success(List<string> messages = null)
        {
            if (messages == null)
                messages = new List<string>();
            messages.Add("Успешно: процедура выполнилась");
            return new Result(true, "Успешно!", "success", messages);
        }

        public static Result Failure(IEnumerable<string> errors) => new Result(false, "Ошибка", "error", errors);

        public static Result Failure(string error) => new Result(false, "Ошибка", "error", new List<string> { error });
    }
}

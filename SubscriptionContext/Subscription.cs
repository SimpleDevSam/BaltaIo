using Balta.SharedContext;

namespace Balta.SubcriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsInActive => EndDate <= DateTime.Now;
    }
}

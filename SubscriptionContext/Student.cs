using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubcriptionContext 
{
    public class Student : Base 
    {

        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public User User { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium => Subscriptions.Any(X=>!X.IsInActive);

        public void CreateSubscription (Subscription subscription) 
        {
            if(IsPremium)
                {
                    AddNotification(new Notification("Premium","O aluno já tem uma assinatura ativa"));
                    return;
                }
            Subscriptions.Add(subscription);
        }

    }
} 
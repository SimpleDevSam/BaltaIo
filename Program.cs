using System;
using System.ComponentModel;
using Balta.ContentContext;
using Balta.ContentContext.Enums;
namespace Balta 
{
    public class Program {
        public static void Main(string[] args)
        {
            var articles = new List<Article>();

            articles.Add(new Article("Artigo sobre ODP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre ODP2", "orientacao-objetos2"));
            articles.Add(new Article("Artigo sobre ODP3", "orientacao-objetos3"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            var courses = new List<Course>();
            var course = new Course("Fundamentos OP","fundamentos-oop");
            var course2 = new Course("Fundamentos OP2","fundamentos-oop2");
            var course3 = new Course("Fundamentos OP3","fundamentos-oop3");
            

            courses.Add(course);
            courses.Add(course2);
            courses.Add(course3);


            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem3 = new CareerItem(3,"3Comece por aqui", "",course);
            var careerItem = new CareerItem(1,"Comece por aqui", "",course3);
            var careerItem2 = new CareerItem(2,"2Comece por aqui", "",course2);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem2);
            careers.Add(careerDotNet);
            

            foreach (var career in careers) {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderByDescending(x=> x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title} - {item.Course.Title}");
                }
            }
            
        }
    }
}
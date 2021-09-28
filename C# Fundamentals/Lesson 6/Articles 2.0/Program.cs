using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticles = new List<Article>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                Article article = new Article();
                string[] input = Console.ReadLine().Split(", ");
                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];

                listOfArticles.Add(article);
            }

            string command = Console.ReadLine();
            

            switch (command)
            {
                case "title":
                    IEnumerable<Article> query = listOfArticles.OrderBy(article => article.Title);
                    foreach (Article article in query)
                    {
                        Console.WriteLine(article.ToString());
                    }
                    break;
                case "content":
                    query = listOfArticles.OrderBy(article => article.Content);
                    foreach (Article article in query)
                    {
                        Console.WriteLine(article.ToString());
                    }
                    break;
                case "author":
                    query = listOfArticles.OrderBy(article => article.Author);
                    foreach (Article article in query)
                    {
                        Console.WriteLine(article.ToString());
                    }
                    break;
            }

        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article() { }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article();
            article.Title = input[0];
            article.Content = input[1];
            article.Author = input[2];

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split(": ");

                switch (commandArgs[0])
                {
                    case "Edit":
                        article.Content = commandArgs[1];
                        break;
                    case "ChangeAuthor":
                        article.Author = commandArgs[1];
                        break;
                    case "Rename":
                        article.Title = commandArgs[1];
                        break;
                }
            }

            Console.WriteLine(article.ToString());
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

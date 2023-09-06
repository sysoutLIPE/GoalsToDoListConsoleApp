using System;

using static System.Convert;
using toDoListConsoleApp.Models.Project;

//I want to format the dates to yyyy-MM-dd
internal class Program
{
    public static void Main(string[] args)
    {
        DateTime currentDay = DateTime.Now;
        DateTime currentMonth = DateTime.Now;
        DateTime dateNow = DateTime.Now;

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Welcome to your Projects List!Today is {dateNow.ToString("dd/MM/yyyy")}");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("--------------------------------------------------");




        string option = "0";

        while (option != "3")
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please enter a valid option");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create a new project");
            Console.WriteLine("2. View all projects");
            Console.WriteLine("3. Exit");
            option = Console.ReadLine();

            switch (option)
            {

                case "1":
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("You chose to create a new project");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Please enter the name of your project");
                    string projectName = Console.ReadLine();
                    Console.WriteLine("Please enter the description of your project");
                    string projectDescription = Console.ReadLine();
                    Console.WriteLine("Please enter the start date(with hours, minutes and seconds) of your project");
                    DateTime projectStartDate = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the end date(with hours, minutes and seconds) of your project");
                    DateTime projectEndDate = DateTime.Parse(Console.ReadLine());                
                    Console.WriteLine("Please enter the productivity in percentage you must have to do your project");
                    int projectProductivity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the project id of your project");
                    int projectId = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");

                    Project project = new Project();
                    project.setName(projectName);
                    project.setDescription(projectDescription);
                    project.setStartDate(projectStartDate);
                    project.setEndDate(projectEndDate);
                    project.setProductivity(projectProductivity);
                    project.setProjectId(projectId);

                    Console.WriteLine(project.GetProjectInfo());

                    StreamWriter sw = new StreamWriter($"C:\\Projetos/{project.getName()}.txt");
                    sw.WriteLine(project.GetProjectInfo());
                    sw.Close();
                    break;



                case "2":
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("You chose to view all projects");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    string[] arquivos = Directory.GetFiles("C:\\Projetos", "*.txt", SearchOption.AllDirectories);
 
                    Console.WriteLine("Arquivos:");
                    foreach (string arq in arquivos)
                    {
                        Console.WriteLine(arq);
                    }



                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. choose a project to view your informations");
                    Console.WriteLine("2. go back to the main menu");
                    
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    string option2 = Console.ReadLine();
                    switch (option2)
                    {

                        case "1":
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("You chose to view a project");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Please enter the name of the project you want to view");
                            string projectToView = Console.ReadLine();
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("--------------------------------------------------");
                            foreach (string line in File.ReadLines($"C:\\Projetos/{projectToView}.txt"))
                            {
                                Console.WriteLine(line);
                            }


                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("1. Delete this Project");
                            Console.WriteLine("2. Go back to the main menu");
                            string option3 = Console.ReadLine();

                            switch (option3)
                            {

                                case "1":
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("Repeat the name of the project you want to delete:");
                                    string projectToDelete = Console.ReadLine();
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------");
                                    File.Delete($"C:\\Projetos/{projectToDelete}.txt");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("The project was deleted");
                                    break;


                                case "2":
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("You chose to go back to the main menu");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------");
                                    break;

                                default:
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.WriteLine("Please enter a valid option");

                                    break;
                            }
                        break;




                        case "2":
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("You chose to go back to the main menu");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("--------------------------------------------------");
                            break;

                        default:
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Please enter a valid option");

                            break;

                    }
                
                    break;


                case "3":
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("You chose to exit the program");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    break;

                default:
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Please enter a valid option");

                    break;







            }

        }
    }
}











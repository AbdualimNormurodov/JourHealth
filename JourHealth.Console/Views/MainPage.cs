using JourHealth.Domain.Entites;
using JourHealth.Print.Views.Patients;

namespace JourHealth.Print.Views;

public class MainPage
{
    PatientServiceView patientServiceView=new PatientServiceView();
    public void View()
    {
        Console.WriteLine("----------------Page-------------");
        Console.Write("1.Patient registration\n" +
            "2.Check the medical journal\n" +
            "3.Patient registration update\n" +
            "0.Exit\n");
        Console.WriteLine(">>>>>>>>");
        int choice=int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                UserView();
                break;
            case 2:
                break;
            case 3:
                break;
            case 0:
                break;
            default:
                View(); 
                break;
        }
    }
    public void UserView()
        {
            Console.Write("1.Create\n" +
                "2.Update\n" +
                "3.Delete\n" +
                "4.Get\n" +
                "5.Get all\n" +
                "0.Exit");
            Console.WriteLine(">>>>>>>>");
            int choice= int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    patientServiceView.Create();
                    break;
                case 2:
                    patientServiceView.Update();
                    break;
                case 3:
                    patientServiceView.Delet();
                    break;
                case 4:
                    patientServiceView.GetById();
                    break;
                case 5:
                    patientServiceView.GetAll();
                    break;
                case 0:
                    View();
                    break;
                default:
                    UserView();
                    break;
            }
        }

}

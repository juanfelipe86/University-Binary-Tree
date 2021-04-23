using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector finaciero";
            vicFinPosition.Salary = 750;

            Position contadorPosition = new Position();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "jefe Financiero";
            jefeFinPosition.Salary = 610;

            Position secreFin1Position = new Position();
            secreFin1Position.Name = "secretaria finaciera 1";
            secreFin1Position.Salary = 350;

            Position secreFin2Position = new Position();
            secreFin2Position.Name = "secretaria finaciera 2";
            secreFin2Position.Salary = 310;


            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vicerector Academico";
            vicAcadPosition.Salary = 780;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe de Registro";
            jefeRegPosition.Salary = 640;


            Position secreReg1Position = new Position();
            secreReg1Position.Name = "Secretaria de Registro 1";
            secreReg1Position.Salary = 400;

            Position asist1Position = new Position();
            asist1Position.Name = "Asistente 1 ";
            asist1Position.Salary = 250;


            Position asist2Position = new Position();
            asist2Position.Name = "Asistente 2 ";
            asist2Position.Salary = 170;

            Position mensajPosition = new Position();
            mensajPosition.Name = "Mensajero ";
            mensajPosition.Salary = 90;

            Position secreReg2Position = new Position();
            secreReg2Position.Name = "Secretaria de Registro 2";
            secreReg2Position.Salary = 360;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null,rectorPosition,null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreReg1Position, jefeRegPosition.Name);
          
            universityTree.CreatePosition(universityTree.Root, asist1Position, secreReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secreReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajPosition, asist2Position.Name);
            universityTree.CreatePosition(universityTree.Root, secreReg2Position, jefeRegPosition.Name);



            universityTree.printTree(universityTree.Root);

            float totalSalary = universityTree.Addsalaries(universityTree.Root);
            Console.WriteLine($"total de salarios:{totalSalary} ");
            Console.ReadLine();
        }
    }
}

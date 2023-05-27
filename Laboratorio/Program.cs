using Laboratorio;
using static Laboratorio.GestorEmpleado;
using System;


string databasePath = "c:\\tmp\\gestorEmpleados.db";
GestorEmpleados Empleados = new GestorEmpleados(databasePath);

Empleados.CrearTabla();

GestorEmpleado empleado1 = new GestorEmpleado(1,"Jhon","Contreras",22,"Desarrollador",15600);
Empleados.AgregarEmpleado(empleado1);
GestorEmpleado empleado2 = new GestorEmpleado(2, "Jose", "Contreras", 32, "Desarrollador", 15900);
Empleados.AgregarEmpleado(empleado2);
GestorEmpleado empleado3 = new GestorEmpleado(3, "Miguel", "Castillo", 45, "Desarrollador", 29000);
Empleados.AgregarEmpleado(empleado3);
GestorEmpleado empleado4 = new GestorEmpleado(4, "Jhon", "Contreras", 22, "Desarrollador", 15600);
Empleados.AgregarEmpleado(empleado4);
GestorEmpleado empleado5 = new GestorEmpleado(5, "Jhon", "Contreras", 22, "Desarrollador", 15600);
Empleados.AgregarEmpleado(empleado5);
GestorEmpleado empleado6 = new GestorEmpleado(6, "Jhon", "Contreras", 22, "Desarrollador", 15600);
Empleados.AgregarEmpleado(empleado6);
GestorEmpleado empleado7 = new GestorEmpleado(7, "Jhon", "Contreras", 22, "Desarrollador", 15600);
Empleados.AgregarEmpleado(empleado7);
GestorEmpleado empleado8 = new GestorEmpleado(8, "Jhon", "Contreras", 22, "Desarrollador", 15600);
Empleados.AgregarEmpleado(empleado8);
GestorEmpleado empleado9 = new GestorEmpleado(9, "Jhon", "Contreras", 22, "Desarrollador", 15600);
Empleados.AgregarEmpleado(empleado9);
GestorEmpleado empleado10 = new GestorEmpleado(10, "Jhon", "Contreras", 22, "Desarrollador", 15600);
Empleados.AgregarEmpleado(empleado10);




var empleados = Empleados.ObtenerEmpleados();
foreach (var empleado in empleados)
{
    Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre}, Apellido: {empleado.Apellido}, Edad: {empleado.Edad}, Cargo: {empleado.Cargo}, Salario: {empleado.Sueldo}");
}

Console.ReadLine();


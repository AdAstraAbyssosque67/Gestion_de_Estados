# Sistema de Solicitudes
## Descripcion

Esta proyecto consiste en una aplicación de consola desarrollada en C# que permite gestionar solicitudes de clientes.

El sistema permite registrar solicitudes, visualizarlas, buscar por ID y cambiar su estado. Para el manejo de estados se utiliza un enumerado (enum), lo que facilita la validación y control de los valores permitidos.

## Que es un  Enumerado(enum)?

Un Enum en C# es un tipo de dato que permite definir un conjunto de constantes con nombre.
Se utiliza para representar valores fijos, mejorando la legibilidad y evitando errores con numeros variables o volatiles.

## Ejemplo:

```csharp
enum EstadoSolicitud
{
    Pendiente = 1,
    En_Proceso,
    Completada,
    Cancelada
}
```

# Ejemlpos de Uso

## Registrar una Solicitud

<img width="1919" height="1079" alt="Captura de pantalla 2026-04-18 175810" src="https://github.com/user-attachments/assets/7e30ce1b-5f1a-4787-a6c3-0a4b5c997d5e" />

## Cambiar Estado

<img width="1899" height="1067" alt="Captura de pantalla 2026-04-18 180328" src="https://github.com/user-attachments/assets/4209b1ee-2df9-4ee9-a3c5-f2aee623566c" />

## Mostrar Todas

<img width="1907" height="1079" alt="Captura de pantalla 2026-04-18 175921" src="https://github.com/user-attachments/assets/d9339833-4275-434a-b7fd-c25499e9f61b" />

##

- **Autor:** José Garrido Mesa  
- **Materia:** Programación Básica  
- **Profesor:** Gamalier Reyes del Carmen  






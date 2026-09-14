# Laboratorio # 2

**Fecha:** 31/08/2026

## Contenido del Repositorio

Este laboratorio abarca el diseño e implementación de aplicaciones en C# (.NET) aplicando principios fundamentales de la Programación Orientada a Objetos (POO): instanciación de clases, definición de métodos con parámetros y encapsulamiento mediante propiedades get y set con variables de instancia privadas.

## Tecnologías Utilizadas

* **Lenguaje / Framework:** C# (.NET Framework / .NET Core)
* **Tipo de Aplicación:** Aplicación de Consola
* **Herramientas:** Visual Studio, Visual Studio Code, Git, GitHub

## Capturas de Pantalla y Problemas

### Ejercicio 1: LibroCalificaciones_1 (Instanciación Básica)

Se creó la clase LibroCalificacion definiendo un método público para mostrar un mensaje de bienvenida en consola. Se demostró la instanciación de objetos mediante el operador new y la invocación de sus métodos miembros.

### Ejercicio 2: LibroCalificaciones_2 (Métodos con Parámetros)

Desarrollo de la lógica para recepción de argumentos dinámicos. Se configuraron métodos que aceptan parámetros de tipo cadena para personalizar la información mostrada y se integró la captura de entradas por consola mediante Console.ReadLine().

### Ejercicio 3: LibroCalificaciones_3 (Encapsulamiento y Propiedades)

Configuración de encapsulamiento estricto utilizando el modificador de acceso private en las variables de instancia. Se implementaron propiedades con descriptores get (lectura) y set (escritura) para garantizar la manipulación segura y controlada de los datos.

## Estructura de Carpetas o Directorios

```text
Laboratorio-2-HPA3-/
├── LibroCalificaciones_1/
│   └── LibroCalificaciones_1/
│       ├── App.config                  # Configuración del proyecto
│       ├── Class1.cs                   # Clase auxiliar por defecto
│       ├── LibroCalificacion.cs        # Definición de la clase básica
│       ├── LibroCalificaciones_1.csproj # Archivo de proyecto C#
│       └── Program.cs                  # Punto de entrada de la aplicación
├── LibroCalificaciones_2/
│   └── LibroCalificaciones_2/
│       ├── App.config                  # Configuración del proyecto
│       ├── Class1.cs                   # Lógica de métodos con parámetros
│       ├── LibroCalificaciones_2.csproj # Archivo de proyecto C#
│       └── Program.cs                  # Entrada de datos desde consola
├── LibroCalificaciones_3/
│   └── LibroCalificaciones_3/
│       ├── App.config                  # Configuración del proyecto
│       ├── Class1.cs                   # Encapsulamiento con propiedades get/set
│       ├── LibroCalificaciones_3.csproj # Archivo de proyecto C#
│       └── Program.cs                  # Prueba de descriptores de acceso
└── README.md                           # Documentación del proyecto
```

## Instrucciones de Ejecución / Uso

* **Clonar el repositorio:**

```bash
git clone https://github.com/AlissonLacayo/Laboratorio-2-HPA3-.git
```

* **Configurar el entorno local:** Abrir la carpeta del proyecto en Visual Studio o Visual Studio Code.

* **Ejecutar el comando de arranque:** Navegar desde la consola a la carpeta de la actividad deseada (por ejemplo, `LibroCalificaciones_1/LibroCalificaciones_1`) y ejecutar:

```bash
dotnet run
```

También se puede abrir la solución en Visual Studio y presionar F5.

## Autor

**Nombre:** Alisson Lacayo

**Asignatura:** Herramientas de Programación Aplicada III (.NET)

**Grupo:** 1IL133

**Carrera:** Licenciatura en Ingeniería en Sistemas y Computación

**Institución:** Universidad Tecnológica de Panamá (UTP)

**Fecha de Realización:** 31/08/2026

## Referencias

* Material didáctico del curso Herramientas de Programación Aplicada III (UTP).
* Directrices del Resumen del Repositorio (UTP - FISC).

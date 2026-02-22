# Directorio de Empleados — .NET MAUI

![App Screenshot](https://raw.githubusercontent.com/JorgeSepul/DirectorioEmpleadosMaui/master/Captura%20de%20pantalla%202026-02-22%20204828.png)

---

## Descripción

**Directorio de Empleados** es una aplicación móvil y de escritorio multiplataforma desarrollada con **.NET MAUI** que permite gestionar la información del personal de una organización de manera centralizada e intuitiva. La app implementa operaciones **CRUD** completas (Crear, Leer, Actualizar y Eliminar) sobre un directorio de empleados almacenado en una base de datos local.

### Funcionalidades principales

- **Registro de empleados** — Agregar nuevos empleados con sus datos personales y laborales.
- **Consulta del directorio** — Visualizar el listado completo de empleados de forma clara.
- **Edición de información** — Actualizar los datos de un empleado existente.
- **Eliminación** — Dar de baja a un empleado del sistema.
- **Multiplataforma** — Compatible con Android, iOS, Windows y macOS desde una sola base de código.

---

## Tecnologías utilizadas

| Tecnología | Descripción |
|---|---|
| [.NET MAUI](https://learn.microsoft.com/es-es/dotnet/maui/) | Framework multiplataforma principal |
| C# | Lenguaje de programación |
| XAML | Definición de interfaces de usuario |
| MVVM | Patrón de arquitectura Model-View-ViewModel |
| SQLite / Base de datos local | Persistencia de datos |
| .NET 8 / .NET 9 | Runtime de la aplicación |
| Visual Studio 2022 | IDE recomendado |

---

## Estructura del proyecto
```
DirectorioEmpleadosMaui/
│
├── Models/              # Clases de modelo (entidades de datos)
├── ViewModels/          # Lógica de presentación (patrón MVVM)
├── Views/               # Páginas XAML de la interfaz de usuario
├── Service/             # Servicios de acceso a datos y lógica de negocio
├── Platforms/           # Código específico por plataforma (Android, iOS, Windows...)
├── Resources/           # Recursos estáticos (imágenes, fuentes, estilos)
├── Properties/          # Configuración del proyecto
│
├── App.xaml             # Recursos globales de la aplicación
├── AppShell.xaml        # Navegación principal (Shell)
├── MauiProgram.cs       # Punto de entrada y configuración de servicios
└── DirectorioEmpleadosMawi.csproj  # Archivo de proyecto
```

---

## Requisitos previos

Antes de ejecutar el proyecto, asegúrate de tener instalado:

- [.NET SDK 8.0 o superior](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/es/) con la carga de trabajo **.NET Multi-platform App UI**
- Emulador de Android / iOS o dispositivo físico (opcional para pruebas móviles)

---

## Instalación y ejecución

1. **Clona el repositorio:**
```bash
   git clone https://github.com/JorgeSepul/DirectorioEmpleadosMaui.git
   cd DirectorioEmpleadosMaui
```

2. **Abre la solución en Visual Studio 2022:**

   Abre el archivo `DirectorioEmpleadosMawi.slnx` con Visual Studio 2022.

3. **Restaura los paquetes NuGet:**

   Visual Studio los restaurará automáticamente. Si no, ejecuta:
```bash
   dotnet restore
```

4. **Selecciona la plataforma de destino** (Android, iOS, Windows, etc.) desde la barra de herramientas de Visual Studio.

5. **Ejecuta la aplicación** presionando `F5` o el botón de ejecución de Visual Studio.

---

## Licencia

Este proyecto está distribuido bajo la licencia **MIT**. Consulta el archivo [LICENSE](LICENSE) para más información.
```
MIT License

Copyright (c) 2026 Jorge Sepúlveda

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
```

---

## Creditos / Autores

| Autor | GitHub |
|---|---|
| **Jorge Sepúlveda** | [@JorgeSepul](https://github.com/JorgeSepul) |

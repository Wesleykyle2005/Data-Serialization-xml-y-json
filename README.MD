## DataSerializationEmployees

DataSerializationEmployees es una aplicación de Windows Forms desarrollada en C# que permite a los usuarios gestionar y serializar datos de empleados en formatos XML y JSON de manera intuitiva y eficiente.

### Características principales:

1. **Gestión de empleados**: Los usuarios pueden agregar, eliminar y visualizar empleados utilizando una interfaz gráfica simple y fácil de usar.

2. **Serialización de datos**: La aplicación permite a los usuarios guardar los datos de empleados en archivos XML o JSON en su sistema de archivos local para su posterior recuperación y procesamiento.

3. **Carga de archivos**: Los usuarios pueden cargar archivos previamente serializados en formatos XML o JSON y visualizar los datos de empleados en la aplicación.

4. **Validación de datos**: Se implementa una validación de datos para garantizar que los campos obligatorios estén completos y que los datos ingresados sean válidos antes de agregar un nuevo empleado o realizar una serialización.

### Manejo de errores:

La aplicación maneja los siguientes errores y proporciona mensajes de error claros al usuario:

- **Campos obligatorios vacíos**: Se muestra un mensaje de error si se intenta agregar un empleado con campos obligatorios vacíos.
- **Formato de salario incorrecto**: Se muestra un mensaje de error si el salario ingresado no es un número positivo válido.
- **Formato de archivo no válido**: Se muestra un mensaje de error si se intenta cargar un archivo con un formato incorrecto que no sea XML o JSON.
- **Error al cargar el archivo**: Se muestra un mensaje de error detallado si ocurre algún problema durante la carga de un archivo serializado.
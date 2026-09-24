# Laboratorio - CRUD de Productos en C#

Ejercicio desarrollado para practicar la creación de un **CRUD (Crear, Leer, Actualizar y Eliminar)** utilizando **C# Windows Forms**, conexión a una base de datos MySQL y programación orientada a objetos.

**Laboratorio de Base de Datos-CRUD**  
**Universidad Tecnológica de Panamá - Facultad de Ingeniería en Sistemas**

**Programado por:** Kevin Esquivel

---

## 📋 Descripción

Este laboratorio implementa un sistema para la **gestión de productos**, permitiendo registrar, consultar, modificar y eliminar información almacenada en una base de datos MySQL.

Cada producto contiene información como:

- Nombre
- Precio
- Cantidad
- Imagen

El sistema utiliza un **DataGridView** para mostrar los productos registrados y permite seleccionar un registro para modificarlo o eliminarlo. También cuenta con un campo de búsqueda para filtrar los productos registrados.

---

## 🔧 Funciones principales

El programa permite realizar las operaciones básicas de un CRUD:

- **Crear:** registrar nuevos productos en la base de datos.
- **Leer:** mostrar los productos almacenados en el DataGridView.
- **Actualizar:** modificar los datos de un producto seleccionado.
- **Eliminar:** eliminar un producto de la base de datos.
- **Buscar:** filtrar productos mediante el campo de búsqueda.
- **Imágenes:** seleccionar y almacenar una imagen asociada al producto.

También se implementaron interfaces para la validación de los campos, utilizando diferentes validadores para texto, números enteros y valores decimales.

Para el manejo de los datos se utiliza un **Dictionary<string, object>** para enviar los parámetros de las operaciones hacia la base de datos. Las imágenes son convertidas a arreglos de bytes mediante **MemoryStream** para poder almacenarlas en MySQL.

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET
- **IDE:** Visual Studio
- **Tipo de aplicación:** Windows Forms
- **Base de datos:** MySQL
- **Conexión:** MySql.Data
- **Paradigmas:** Programación Orientada a Objetos e interfaces de C#

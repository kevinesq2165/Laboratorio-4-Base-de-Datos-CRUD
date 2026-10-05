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
  CRUD:
  <img width="609" height="525" alt="image" src="https://github.com/user-attachments/assets/68da7a48-955a-498e-9c19-48c347ccc72e" />
  Insertar imágenes:
  <img width="736" height="250" alt="image" src="https://github.com/user-attachments/assets/1c6f7ef2-b9ae-43b0-90a7-38179c8a48e4" />
  Modificando la imagen del raton gamer :
  <img width="469" height="273" alt="image" src="https://github.com/user-attachments/assets/699ee946-40e7-4229-a3d3-73c79b305db3" />
  Eliminando registros:
  <img width="608" height="529" alt="image" src="https://github.com/user-attachments/assets/fff94274-72f9-49b4-8196-2989331543ab" />
 

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

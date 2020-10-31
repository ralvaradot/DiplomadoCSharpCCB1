<h1>Analisis de la Aplicacion de recursos Humanos</h1>

Para apoyarnos en el curso vamos a desarrollar una aplicacion de apoyo a recursos humanos.

Esta pequeña aplicacion permitira manejar los datos de los empleados de la empresa.

Al  pensar en los empleados debemos imaginar que necesitamos de cada empleado para poder plasmarlo en un programa de computador.

Y de la misma manera debemos pensar para las entidades que soportan o que nos permiten agregar datos al empleado.

<h3>Empleado:</h3>

- Nombres
- Apellidos
- Fecha de Nacimiento
- Tipo de Documento de Identificacion
- Numero de documento de identificacion
- Direccion
- Ciudad de residencia
- Genero
- Numero de Celular
- Estado Civil
- Cargo 
- Jefe
- Fecha de Ingreso a la compañia
- Centro de Costos

De acuerdo a lo anterior necesitamos definir los datos que tendran las tablas o datos que hacen parte del Empleado, 
pero qeu ademas son variables, estos datos son:

- Tipo de Documento de Identificacion
- Ciudad de residencia
- Genero
- Estado Civil
- Cargo
- Centro de Costos

Entonces, cada uno de los anteriores debe tener su propia tabla o definicion, abran algunos que sean tablas de la base de datos 
y otros que pueden ser datos variables pero incluidos dentro de la misma aplicacion, esto lo haremos en una Enumeracion de C#, 
este concepto se encuentra en el desarrollo de software para casi todos los lenguajes, y lo que indica es una lista de valores
enteros (1, 2, ...n) que representan una opcion.

Para nuestro desarrollo vamos a desarrollar los difernetes datos adjuntos o necesarios oara el Empleado, a continuacion vamos a 
realizar las diferentes estructuras:

<h3>Tipo Documento de Identificacion ( Cédula, registro Civil, Cedula de extrajeria, Pasaporte, etc.)</h3>

- Codigo
- Descripcion

<h3>Ciudad (Ciudad de residencia del Empleado asociada a una direccion)</h3>

- Codigo
- Nombre Ciudad

<h3>Genero (Masculino, Femenino, Otro)</h3>

- Codigo
- Descripcion

<h3>Estado Civil (Casado, Soltero, Viudo, etc.)</h3>

- Codigo
- Descripcion

<h3>Cargo ( los definidos por la empresa)</h3>

- Codigo
- Nombre Cargo
- Descripcion del Cargo
- Requisitos
- experiencia minima
- Centro de Costo

<h3>Centro de Costos (Definidos por la empresa)</h3>

- Codigo
- Nombre
- Descripcion
- Director

Si deseamos tener una aplicacion mucho mas profesional, nuestra aplicación debe tener un sistema de seguridad de 
autenticacion y autorizacion para cada accion de nuestra aplicación.

Para esto, debemos tener en cuenta una tabla o entidad para almacenar los usuarios de la aplicacion, así como una 
tabla para crear la realcion entre el usuario y la opcion de la aplicacion a la cual esta autorizado ejecutar.

Esta tarea nos la facilita el framework de .NEt pues ya el Framework cuenta con esta funcionalidad.

Hasta aqui llega el analisis de nuestra aplicacion para Recursos Humanos de nuestra empresa.


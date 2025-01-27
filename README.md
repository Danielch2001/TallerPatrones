<<<<<<< HEAD
Pepito es un Ingeniero de Software Junior en Codificando Con Patrones Cía. Ltda. Se le ha encargado la tarea de completar los requerimientos funcionales del aplicativo de automóviles al que la empresa da soporte. 

Los requisitos son los siguientes: 

- Implementar los métodos de agregar vehículos (add Mustang y add Explorer) en el Home Page. El programador anterior implementó un patrón repositorio que contiene los métodos CRUD para el repositorio de automóviles; sin embargo, el equipo de QA ha reportado que no funciona como se espera. 
 

- El equipo de base de datos ha comentado que el esquema de la base de datos no está listo. Por lo que se necesita buscar una forma de probar la funcionalidad sin tener que guardar en la base de datos, de tal forma que después se implemente la funcionalidad de base de datos cuando esté lista. 

- El equipo de negocio ha solicitado agregar el año actual, y 20 propiedades más por defecto que se solicitarán en el siguiente sprint. Estas propiedades afectan a vehículo. Implementa un patrón de diseño para agregar propiedades por defecto, y como lo diseñarías para minimizar los cambios para el siguiente sprint. 

- Se planea agregar un nuevo modelo. El Arquitecto de Software prevee que la unidad de negocio, planeará la introducción de más modelos por lo cual sugiere la implementación de un Factory Method. 

  - Color: Red 

  - Marca: Ford 

  - Modelo: Escape 

 

 

Como primera parte del taller los alumnos tendrán: 

Que analizar el código propuesto y deberán identificar que mejores prácticas, patrón o patrones se puede implementar para mejorar la solución. 

Segundo deberán presentar en un documento explicativo de las mejores prácticas con el diseño UML del patrón o patrones a implementar y justificar el motivo de la propuesta. 

 Y finalmente los alumnos procederán a clonar el repositorio base e implementar el patrón o los patrones propuestos en la una versión online (código debe tener comentarios) 

 

FORMA DE TRABAJO: 

Establezca grupos de trabajo de máximo 2 integrantes. 

 

ESPECIFICACIONES DE ENTREGA: 

Documento técnico que contiene los siguientes puntos: 

Identifica el problema dentro de las restricciones del proyecto: 	Describir los problemas encontrados en el escenario propuesto por el docente de una manera técnica identificando de manera correcta las limitaciones y restricciones. 

Selecciona metodologías integrales para solucionar el problema: En el documento técnico explicar los patrones que seleccionan y justarlos de manera técnica  

 

Diseña una propuesta técnica para el problema considerando los recursos y restricciones del proyecto: 

Prototipo de la solución aplicado el patrón de diseño, compartido en GIT 

 

 
=======
# Diseño de Patrones de Software - Proyecto de Automóviles

Este proyecto implementa varios patrones de diseño como **Singleton**, **Builder**, y **Factory Method** para la creación y gestión de vehículos dentro de un sistema de automóviles.

## Patrones de Diseño Implementados

1. **Singleton**:
   - El patrón Singleton se utiliza para garantizar que solo haya una instancia de la clase `MemoryCollection` que gestiona la colección de vehículos en memoria. Este patrón asegura que todos los accesos a la colección se realicen a través de una única instancia, evitando inconsistencias.
   
2. **Builder**:
   - El patrón Builder se usa para crear objetos de tipo `CarModel` de manera flexible. Permite configurar diferentes propiedades del vehículo (como el modelo y color) a través de métodos encadenados, y luego crear el objeto final utilizando el método `Build()`.

3. **Factory Method**:
   - El patrón Factory Method es utilizado para crear diferentes tipos de vehículos (como "Mustang", "Explorer" y "Escape") sin exponer los detalles de cómo se crean. Se crea una fábrica específica para cada tipo de vehículo, y se utiliza un método `chooseFactory` para seleccionar la fábrica correcta y crear el objeto correspondiente.

## Estructura del Proyecto

- **Controllers**: Contiene el `HomeController`, donde se invocan los métodos para agregar vehículos utilizando los patrones de diseño implementados.
- **Factories**: Contiene las fábricas concretas que crean los vehículos, como `FordMustangFactory`, `FordExplorerFactory`, y `FordEscapeFactory`.
- **ModelBuilders**: Contiene el `CarModelBuilder`, que se usa para construir los objetos `CarModel`.
- **Models**: Contiene las clases de modelo, como `CarModel`, que representan las entidades de vehículos.
- **Repositories**: Contiene el repositorio que maneja la adición y persistencia de los vehículos.

## Instalación

### Requisitos:
- **.NET SDK** (versión 5.0 o superior)
- **Visual Studio** o cualquier editor compatible con .NET

### Pasos para ejecutar el proyecto:

1. Clona este repositorio en tu máquina local:
   ```bash
   git clone (https://github.com/Danielch2001/TallerPatrones.git)
>>>>>>> 2d34cc8ca74e3c3792159ac9b4c0091b4425a185

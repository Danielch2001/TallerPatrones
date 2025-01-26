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

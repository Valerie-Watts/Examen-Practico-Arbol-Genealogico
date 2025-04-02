# Examen Práctico: Árbol Genealógico

## Descripción del Proyecto
Este proyecto implementa un árbol genealógico en C# con el objetivo de registrar y consultar relaciones familiares. Permite a los usuarios agregar miembros a la estructura de datos, encontrar los padres de un individuo y visualizar el árbol en un recorrido en preorden.

## Objetivos
- Crear una estructura de datos para representar relaciones familiares.
- Implementar operaciones de inserción y búsqueda de padres.
- Imprimir el árbol en orden preorden.

## Instalación y Uso
1. Clona este repositorio o descarga los archivos fuente.
2. Abre el proyecto en Visual Studio o cualquier entorno compatible con C#.
3. Compila y ejecuta el programa.
4. Usa el menú interactivo para agregar miembros y consultar el árbol genealógico.

## Ejemplos de Entrada y Salida
### Ejemplo 1: Agregar miembros
**Entrada:**
```
1
Insert the name of the Child: Alice
Insert the name of the Mother: Emma
Insert the name of the Father: Robert
```
**Salida:**
```
```
(No muestra ningún mensaje de confirmación de inserción)

### Ejemplo 2: Buscar padres
**Entrada:**
```
2
Insert the name of the child whose parents you want to find: Alice
```
**Salida:**
```
Padres de Alice: Madre --> Emma, Padre ---> Robert
```

### Ejemplo 3: Imprimir preorden
**Entrada:**
```
3
```
**Salida:**
```
Alice
Emma
Robert
```

## Explicación del Algoritmo y Complejidad
El proyecto usa una estructura de datos similar a un árbol binario, donde cada nodo representa un miembro de la familia con referencias a su madre y padre. Las operaciones principales tienen las siguientes complejidades:

- **Inserción de un miembro:** O(1), ya que se añade un nodo directamente.
- **Búsqueda de padres:** O(1), dado que la información se almacena directamente en la estructura.
- **Recorrido en preorden:** O(n), donde *n* es el número de nodos en el árbol, ya que se visita cada nodo una vez.

## Autor
Desarrollado como parte del Examen Práctico de estructuras de datos en C#.

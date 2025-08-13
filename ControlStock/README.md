# Gestión de Productos en Stock

## Descripción
Este proyecto permite registrar y visualizar productos en stock mediante una sencilla interfaz de menú.

## Caso de Uso

- **Nombre:** Gestión de Productos en Stock
- **Actor Principal:** Encargado de inventario
- **Objetivo:** Permitir registrar y visualizar productos en stock.

## Precondiciones

- El programa está en ejecución.
- Existe espacio para agregar productos (máximo 10).

## Flujo Principal

1. El sistema muestra un menú con tres opciones:
    - Agregar Producto
    - Listar Productos
    - Salir
2. El encargado selecciona la opción **Agregar Producto**.
3. El sistema solicita:
    - Nombre del producto
    - Cantidad disponible
4. El encargado ingresa los datos solicitados.
5. El sistema guarda el producto y la cantidad.
6. El sistema confirma el registro exitoso.

## Flujo Alterno

- Si se alcanza el máximo de 10 productos, el sistema muestra un mensaje indicando que no se pueden agregar más.

## Postcondiciones

- El producto queda registrado en memoria.
- En la opción **Listar Productos** se pueden visualizar todos los productos y sus cantidades.

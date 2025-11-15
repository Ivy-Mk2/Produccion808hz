# Estructuras de datos y operaciones

Este documento explica cada estructura requerida, sus operaciones clave y complejidades.

## Lista simple (Singly Linked List)
- Operaciones: insertar, eliminar, recorrer, buscar, ordenar, mezclar.
- Complejidades típicas:
  - Insertar al inicio: O(1)
  - Insertar al final (sin cola): O(n)
  - Eliminar por referencia: O(1)
  - Búsqueda/recorrido: O(n)
  - Ordenación (p.ej. inserción/merge sort): O(n log n)
- Caso real: items de una cotización, cálculo de total y ordenación por precio/nombre.

## Lista doble (Doubly Linked List)
- Operaciones: insertar en ambos lados, eliminar, ordenar, recorrido bidireccional.
- Complejidades:
  - Insertar/eliminar en extremos: O(1)
  - Moverse prev/next: O(1)
  - Búsqueda/recorrido: O(n)
- Caso real: calendario de reservas con navegación hacia adelante/atrás por hora.

## Lista circular (Circular Linked List)
- Operaciones: rotación, recorridos continuos, ciclo de mantenimiento/uso.
- Complejidades:
  - Rotación y avance: O(1)
  - Recorrido continuo: O(n) por ciclo
- Caso real: rotación de equipos disponibles y mantenimiento.

## Pila (Stack)
- Operaciones: push, pop, peek; utilidad infija→postfija.
- Complejidades:
  - Push/Pop/Peek: O(1)
  - Conversión infija→postfija: O(n)
- Caso real: Undo/Redo de acciones en cotización.

## Cola (Queue)
- Operaciones: enqueue, dequeue, peek.
- Complejidades:
  - Enqueue/Dequeue/Peek: O(1)
- Caso real: asignación FIFO de técnicos, pedidos en espera y mantenimiento de equipos.

## Árbol binario de búsqueda (ABB)
- Operaciones: insertar, eliminar, buscar, recorridos (inorden, preorden, postorden).
- Complejidades promedio:
  - Insertar/Eliminar/Buscar: O(log n) (árbol balanceado), O(n) en peor caso lineal
  - Recorridos: O(n)
- Caso real: índices de clientes por DNI/ID/nombre y de inventario por ID/nombre.

## Grafo (ponderado)
- Representación: lista de adyacencia con pesos enteros (costos/distancias).
- Algoritmos:
  - BFS: conectividad, niveles → O(V+E)
  - DFS: exploración de rutas → O(V+E)
  - Dijkstra: ruta más corta con pesos no negativos → O((V+E) log V) con cola de prioridad
  - Floyd–Warshall: todas las parejas → O(V^3)
- Casos reales: logística de rutas (mapa de entregas y montaje), dependencias paquete→productos.

## Integración con el proyecto
- Cada servicio usa la estructura que mejor modela su problema.
- Persistencia en JSON y demostraciones en UI, sin acoplar estructuras a la interfaz.
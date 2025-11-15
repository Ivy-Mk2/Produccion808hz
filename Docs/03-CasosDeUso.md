# Casos de uso y secuencias

Este documento describe los flujos principales del sistema y cómo cada estructura participa.

## Crear cotización (Lista simple + Pila)
- Flujo: seleccionar cliente → agregar items → calcular total → deshacer/rehacer → guardar.
```mermaid
sequenceDiagram
  participant V as View (MainForm)
  participant P as Presenter
  participant Q as QuoteService
  participant U as UndoRedoService
  participant J as JsonStorageService
  V->>P: Agregar item a cotización
  P->>Q: Insertar item en lista simple
  Q-->>P: Total actualizado
  P->>U: Registrar acción (push)
  V->>P: Deshacer
  P->>U: Pop acción
  P->>Q: Revertir cambio
  V->>P: Guardar cotización
  P->>J: Persistir en Quotes.json
```

## Calendario de reservas (Lista doble)
- Flujo: elegir día → navegar reservas prev/next → insertar/eliminar → ordenar por hora.
```mermaid
sequenceDiagram
  participant V as View
  participant P as Presenter
  participant R as ReservationService
  V->>P: Día seleccionado
  P->>R: Cargar reservas del día (lista doble)
  V->>P: Siguiente/Anterior
  P->>R: Mover puntero prev/next
  V->>P: Insertar/Eliminar
  P->>R: Operación en lista doble
```

## Rotación de inventario (Lista circular)
- Flujo: iterar equipos disponibles → rotar al siguiente → marcar mantenimiento.
```mermaid
sequenceDiagram
  participant V as View
  participant P as Presenter
  participant I as InventoryService
  V->>P: Mostrar equipo actual
  P->>I: Obtener nodo activo (circular)
  V->>P: Rotar
  P->>I: Mover al siguiente
```

## Asignación de técnicos (Cola)
- Flujo: técnicos en espera → llegada de pedido → asignar FIFO → actualizar estado.
```mermaid
sequenceDiagram
  participant V as View
  participant P as Presenter
  participant L as LogisticsService
  V->>P: Nuevo pedido
  P->>L: Dequeue técnico
  L-->>P: Técnico asignado
  P-->>V: Mostrar asignación
```

## Búsquedas de clientes/productos (ABB)
- Flujo: construir índice por clave → insertar elementos → búsquedas y recorridos.
```mermaid
sequenceDiagram
  participant P as Presenter
  participant C as ClientIndexService
  P->>C: Construir índice por DNI
  P->>C: Insertar clientes
  P->>C: Buscar DNI
  C-->>P: Cliente encontrado
```

## Rutas logísticas (Grafo)
- Flujo: verificar conectividad (BFS) → explorar rutas (DFS) → ruta más corta (Dijkstra) → matriz de costos (Floyd–Warshall).
```mermaid
sequenceDiagram
  participant P as Presenter
  participant G as LogisticsService (Graph)
  P->>G: BFS origen
  G-->>P: Nodos alcanzables
  P->>G: DFS entre A y B
  G-->>P: Ruta explorada
  P->>G: Dijkstra A→B
  G-->>P: Distancia mínima
  P->>G: Floyd–Warshall
  G-->>P: Matriz de costos
```

## Alta de cliente (Clientes)
- Flujo: ingresar datos → validar → guardar en JSON → actualizar índices → confirmar.
```mermaid
sequenceDiagram
  participant V as View (Clientes)
  participant P as Presenter (Clientes)
  participant S as ClientService
  participant J as JsonStorageService
  V->>P: Guardar nuevo cliente
  P->>S: Validar y preparar entidad
  S->>J: Persistir en data/Clients.json
  S-->>P: Confirmación
  P-->>V: Actualizar listado / mensaje
```
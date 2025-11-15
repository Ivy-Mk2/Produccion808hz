## Alcance y entregables
- Documentación ordenada y completa del proyecto Productora 808xHz, SIN incluir código.
- Gráficos: UML de clases y módulos, secuencias de casos de uso, diagramas de rutas y dependencias.
- Justificación empresarial y vínculo explícito entre cada estructura y su módulo.

## Organización de la documentación
- Carpeta `Docs/` con subcarpeta `Docs/diagramas/`.
- Formatos: Markdown (Mermaid) y PlantUML para exportar a PNG.
- Entregables en español, listos para informe académico/empresarial.

## Índice de documentos
1. `Docs/00-Resumen.md`
   - Tabla: Estructura ↔ Módulo ↔ Justificación.
   - Cumplimiento del sílabo y del informe.
2. `Docs/01-Arquitectura.md`
   - Visión general (MVP: Models/Services/Presenters/Views).
   - Diagrama de módulos y flujo de datos.
3. `Docs/02-Estructuras.md`
   - Explicación conceptual de: Lista simple, Lista doble, Lista circular, Pila, Cola, ABB, Grafo.
   - Operaciones cubiertas y complejidades Big‑O.
   - Escenarios reales del proyecto para cada estructura.
4. `Docs/03-CasosDeUso.md`
   - Secuencia “Crear cotización” (Lista simple + Pila Undo/Redo).
   - Secuencia “Calendario de reservas” (Lista doble).
   - Secuencia “Rotación de inventario” (Lista circular).
   - Secuencia “Asignación de técnicos” (Cola).
   - Secuencia “Búsqueda de clientes/productos” (ABB).
   - Secuencia “Rutas logísticas” (Grafo + BFS/DFS/Dijkstra/Floyd‑Warshall).
5. `Docs/04-Grafos.md`
   - Grafo de rutas: conectividad, exploración, ruta óptima, matriz de costos.
   - Grafo paquetes→productos: dependencias y agrupaciones.
6. `Docs/uml/` gráficos
   - `classDiagram.mmd`: modelos y estructuras (vista conceptual, sin código).
   - `modules.mmd`: servicios y relaciones.
   - `sequence-*.mmd`: secuencias de casos de uso.
   - `all.puml`: versión PlantUML para exportación.

## Gráficos (contenido previsto)
- UML de clases (conceptual): Cliente, Producto, Cotización/Item, Reserva, Técnico, Accion.
- Diagramas de módulos: QuoteService, ReservationService, InventoryService, LogisticsService, PackageService, Client/Product Index.
- Secuencias: paso a paso de cada caso de uso.
- Grafos:
  - Rutas: nodos (sedes/zonas), aristas ponderadas (costos/distancias).
  - Paquetes→productos: grafo dirigido de dependencias.

## Justificación empresarial
- Reforzar “por qué” cada estructura se ajusta al proceso real (cotizaciones, reservas, inventario, logística, reportes).
- Vincular decisiones a eficiencia, mantenibilidad y claridad operativa.

## Metodología
- Redactar documentación basada en el proyecto actual y en tu sílabo.
- Usar ejemplos narrativos y diagramas; NO incluir fragmentos de código.
- Entregar archivos Markdown + fuentes de diagramas y PNG exportables.

## Entregables finales
- Carpeta `Docs/` completa con Markdown y gráficos.
- Diagrama UML y de grafos listos para impresión/presentación.

¿Confirmas que procedamos con la creación de la documentación y los gráficos SIN código?
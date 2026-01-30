#### Buenas practivas
* Explicar por que
* Aclarar las decisiones no obias en el codigo
* Advertencias sobre casos especiales
* Documentar entradas y salidas (inputs, outputs, errors)

#### Malas practicas
* Comentar algo que ya es obio
* Explicar cada linea del codigo
* Dejar comentarios desactualizados
* Justificar codigo confuso
* Codigo que ya no se usa comentado

#### When should you add comments?
They should be added when the code alone does not express what it does, or has very complex logic, in addition to leaving important comments there to explain what that code does and what its functionality is.

#### When should you avoid comments and instead improve the code?
Cuando el codigo es muy facil de entender, por ejemplo dejando nombre de variables y funciones de una forma mas clara.

JS example:
```
// Bad
function add(a,b){
    // Return add a and b
    return a+b; // return the result
}

// Correct
/**
 * adds two numeric values
 * Throws an error if the inputs are not numbers.
 */

function add (a,b) {
    if (typeof a !== "number" || typeof b !== "number") {
        throw new TypeError("Both parameters must be numbers");
    }

    return a + b;
}

```
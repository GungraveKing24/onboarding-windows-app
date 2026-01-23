#### What makes a good variable or function name?
Name variables and functions descriptively and specifically, clearly communicating their purpose. This makes the code easier to read without needing so many comments.

#### What issues can arise from poorly named variables?
Poorly named variables make the code harder to read and increase confusion and errors when modifying or using something that isn't understood.

#### How did refactoring improve code readability?
Refactoring greatly improved readability by giving variables and functions concrete names that describe what they do. This makes the code easier to understand without using comments.

Code in JS
```
// Not understandable

function f(a, b) {
    let x = 0;

    for (let i = 0; i < a.length; i++) {
        x += a[i].p * a[i].q;
    }

    if (b) {
        x = x - x * b;
    }

    return x;
}

// Understandable

function calculateOrderTotal(items, discountRate) {
    let totalPrice = 0;

    for (const item of items) {
        totalPrice += item.price * item.quantity;
    }

    if (discountRate) {
        totalPrice -= totalPrice * discountRate;
    }

    return totalPrice;
}
```
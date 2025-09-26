// ГАЛЕРЕЯ — перемикання головного фото
const thumbs = document.querySelectorAll('.thumb');
const mainImage = document.getElementById('mainImage');

thumbs.forEach(thumb => {
    thumb.addEventListener('click', () => {
        // замінюємо головне фото
        mainImage.src = thumb.src;

        // прибираємо active у всіх мініатюрах
        thumbs.forEach(t => t.classList.remove('active'));
        // додаємо active для вибраного
        thumb.classList.add('active');
    });
});

// ЛІЧИЛЬНИК — кількість товару
const decreaseBtn = document.getElementById('decrease');
const increaseBtn = document.getElementById('increase');
const quantityInput = document.getElementById('quantity');

decreaseBtn.addEventListener('click', () => {
    let value = parseInt(quantityInput.value);
    if (value > 1) {
        quantityInput.value = value - 1;
    }
});

increaseBtn.addEventListener('click', () => {
    let value = parseInt(quantityInput.value);
    quantityInput.value = value + 1;
});

// КОЛІР — вибір
const colors = document.querySelectorAll('.color');
colors.forEach(color => {
    color.addEventListener('click', () => {
        colors.forEach(c => c.classList.remove('active'));
        color.classList.add('active');
        console.log("Вибраний колір:", color.dataset.color);
    });
});

// РОЗМІР — вибір
const sizes = document.querySelectorAll('.sizes button');
sizes.forEach(size => {
    size.addEventListener('click', () => {
        sizes.forEach(s => s.classList.remove('active'));
        size.classList.add('active');
        console.log("Вибраний розмір:", size.dataset.size);
    });
});

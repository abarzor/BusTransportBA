var myCarousel = new bootstrap.Carousel(document.getElementById('carouselExampleIndicators'), {
    interval: 1000
});

document.addEventListener('DOMContentLoaded', () => {
    const busLayout = document.querySelector('.bus-layout');
    const numberOfSeats = 52;

    for (let i = 1; i <= numberOfSeats; i++) {
        const seat = document.createElement('div');
        seat.classList.add('seat');
        seat.innerHTML = `<span>${i}</span>`;
        busLayout.appendChild(seat);

        seat.addEventListener('click', () => {
            seat.style.backgroundColor = seat.style.backgroundColor === 'green' ? 'lightgrey' : 'green';
        });
    }
});
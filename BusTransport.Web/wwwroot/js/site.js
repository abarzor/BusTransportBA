var myCarousel = new bootstrap.Carousel(document.getElementById('carouselExampleIndicators'), {
    interval: 1000
});

document.addEventListener('DOMContentLoaded', () => {
    const busLayout = document.querySelector('.bus-layout');
    const numberOfSeats = 52;
    const takenSeatsCount = Math.floor(Math.random() * numberOfSeats); // Random number of taken seats

    for (let i = 1; i <= numberOfSeats; i++) {
        const seat = document.createElement('div');
        seat.classList.add('seat');
        seat.innerHTML = `<span>${i}</span>`;
        busLayout.appendChild(seat);

        seat.addEventListener('click', () => {
            if (!seat.classList.contains('taken')) { // Only toggle if seat is not taken
                seat.style.backgroundColor = seat.style.backgroundColor === 'green' ? 'lightgrey' : 'green';
            }
        });
    }

    // Randomly mark some seats as taken
    markRandomSeatsAsTaken(busLayout, takenSeatsCount);
});

function markRandomSeatsAsTaken(busLayout, count) {
    const seats = busLayout.querySelectorAll('.seat');
    const takenIndices = new Set();

    while (takenIndices.size < count) {
        const randomIndex = Math.floor(Math.random() * seats.length);
        takenIndices.add(randomIndex);
    }

    takenIndices.forEach(index => {
        const seat = seats[index];
        seat.style.backgroundColor = '#778da9';
        seat.classList.add('taken'); // Add 'taken' class to prevent toggling
    });
}

document.addEventListener("DOMContentLoaded", function () {
    var today = new Date().toISOString().split('T')[0];

    document.getElementById('departureDate').value = today;
});

document.querySelectorAll('.manageNavButton').forEach(item => {
    item.addEventListener('click', function () {
        document.querySelectorAll('.manageNavButton').forEach(nav => {
            nav.classList.remove('active');
        });

        this.classList.add('active');
    });
});

document.addEventListener("DOMContentLoaded", function () {
    var startingBusStop = document.getElementById('startingBusStop');
    var endingBusStop = document.getElementById('endingBusStop');
    var seatSelectionArea = document.getElementById('seatSelectionArea');

    function updateSeatSelectionArea() {
        if ((startingBusStop.selectedIndex > 0 && endingBusStop.selectedIndex > 0)) {
            seatSelectionArea.style.pointerEvents = 'all';
            seatSelectionArea.style.opacity = 1;
        } else {
            seatSelectionArea.style.pointerEvents = 'none';
            seatSelectionArea.style.opacity = 0.5;
        }
    }

    startingBusStop.addEventListener('change', updateSeatSelectionArea);
    endingBusStop.addEventListener('change', updateSeatSelectionArea);
});

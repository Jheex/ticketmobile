document.addEventListener('DOMContentLoaded', function() {
    const ctx = document.getElementById('statusChart').getContext('2d');
    
    const statusChart = new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ['Aberto', 'Fechado', 'Pendente'],
            datasets: [{
                label: 'Tickets',
                data: [
                    ticketsAbertos,
                    ticketsFechados,
                    ticketsPendentes
                ],
                backgroundColor: ['#28a745', '#dc3545', '#ffc107'],
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            aspectRatio: 0.7,
            plugins: {
                legend: {
                    position: 'bottom',
                },
            }
        }
    });
});
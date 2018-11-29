var ctx = document.getElementById("pauseChart").getContext("2d");
var myLine = new Chart(ctx, {
    type: 'line',
    data: {
        xLabels: ["29-11", "30-11", "01-12", "02-12", "03-12", "04-12", "05-12"],
        yLabels: ['1:30', '1:15', '1', '0:45', '0:30', '0:15'],
        datasets: [{
            label: "My First Dataset",
            data: ['1', '0:45', '1:15', '0:30', '1', '0:15', '1'],
            fill: false,
            showLine: true,
            borderColor: "lightcoral"
        }, {
            label: "My First dataset",
            data: [null, 'Request Accepted', 'Request Accepted'],
            fill: false,
            showLine: false
        }]
    },
    options: {
        responsive: true,
        title: {
            display: true,
            text: 'Uren Genomen Pauze'
        },
        legend: {
            display: false
        },
        scales: {
           
            yAxes: [{
                type: 'category',
                position: 'left',
                display: true,

                ticks: {
                    reverse: true
                }
                
            }]
            
        }
    }
});
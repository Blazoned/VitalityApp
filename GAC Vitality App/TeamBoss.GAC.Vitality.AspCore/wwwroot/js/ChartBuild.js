var ctx = document.getElementById("sleepChart").getContext("2d");
var myLine = new Chart(ctx, {
    type: 'line',
    data: {
        xLabels: ["29-11", "30-11", "01-12", "02-12", "03-12", "04-12", "05-12"],
        yLabels: ['10 uur', '9 uur', '8 uur', '7 uur', '6 uur', '5 uur', '4 uur', '3 uur', '2 uur', '1 uur'],
        datasets: [{
            label: "Uren Geslapen",
            data: ['7 uur', '6 uur', '5 uur', '8 uur', '5 uur', '3 uur', '8 uur'],
            fill: false,
            showLine: true,
            borderColor: "lightblue"
        }, {
            label: "Uren Geslapen",
            data: [null, 'Request Accepted', 'Request Accepted'],
            fill: false,
            showLine: false
        }]
    },
    options: {
        responsive: true,
        title: {
            display: true,
            text: 'Uren Geslapen'
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
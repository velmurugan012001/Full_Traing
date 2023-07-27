import './ExpenseDateLoad.css'
function ExponseDateLoad(props)
{
    const day = props.expdate.toLocalstring("en-us",{ day:"2-digit"});

    const month = props.expdate.toLocalstring("en-us",{ month:"long"});
    const year = props.expdate.getFullYear();
     return (  <div class="expensedate">
            <div class="expensedate-day">{day}</div>
            <div class="expensedate">{date}</div>
            <div>{year}</div>
        </div>
    );
}

export default ExponseDateLoad;
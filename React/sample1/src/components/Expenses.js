import"./ExpenseDateLoad";
import "./Exponses.css";
function Exponses(props){
    return(
        <div>
            <card></card>
            <div>
                <ExpenseDateLoad expdate={props.expdate}></ExpenseDateLoad>
            </div>
            <div>{props.expenses} {props.expamouint}</div>
            {PaymentResponse.exptype}
        </div>

    );
}


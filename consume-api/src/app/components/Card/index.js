import styles from './card.module.css';
import 'bootstrap/dist/css/bootstrap.min.css';

 
export default async function Card() {
	 process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0';

    const cards = await fetch('http://localhost:5130/api/Viagem').then(res => res.json());
    console.log(cards);
 
    return (
        <div className={styles.container}>
            {cards?.map((card) => (
                <div key={card.id} className={styles.card}>
                    <img src={card.viagemURL} alt={card.title} />
                    <div className={styles.card_title}>
					<p>{card.destino}</p>
					<p>10x R${card.preco}</p>
                    </div>
                </div>
            ))}
        </div>
    )
}
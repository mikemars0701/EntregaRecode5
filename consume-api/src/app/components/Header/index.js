import Link from 'next/link'

export default function Header() {
	return (
		<header className="header">
			<div className="cordanav">
        <nav className="navbar navbar-expand-lg bg-body-primary">
            <div className="container-fluid">
				<h1>Spacebook </h1>
                <a className="navbar-brand">
                    
                </a>

                
                    

                    
                    <ul className="navbar-nav">

					<li>
					<Link href="/RotaUm" className="btn btn-dark">Viagens</Link>
						</li>

						<li>
					<Link href="/RotaUm" className="btn btn-dark disabled">Passageiros</Link>
						</li>

						<li>
					<Link href="/RotaUm" className="btn btn-dark disabled">Pilotos</Link>
						</li>
                        

                   

                    </ul>
                

            </div>
        </nav>
    </div>
		</header>
	)
}
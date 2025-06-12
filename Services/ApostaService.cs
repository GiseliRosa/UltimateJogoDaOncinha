using JogoDaOncinha.Models;
using JogoDaOncinha.Repositories;
using System.Collections.Generic;

namespace JogoDaOncinha.Services
{
    // A camada de serviço aplica regras de negócio entre a interface do usuário e o repositório
    public class ApostaService
    {
        private readonly ApostaRepository _apostaRepository;

        // Injeção de dependência do repositório
        public ApostaService(ApostaRepository apostaRepository)
        {
            _apostaRepository = apostaRepository;
        }

        public void AdicionarAposta(Aposta aposta)
        {
            _apostaRepository.Add(aposta);
        }

        public IEnumerable<Aposta> ObterTodasApostas()
        {
            return _apostaRepository.GetAll();
        }

        public Aposta ObterApostaPorId(int id)
        {
            return _apostaRepository.GetById(id);
        }

        public void AtualizarAposta(Aposta aposta)
        {
            _apostaRepository.Update(aposta);
        }

        public void DeletarAposta(int id)
        {
            _apostaRepository.Delete(id);
        }
    }
}

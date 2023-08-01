
using System.Security.Cryptography.X509Certificates;
using Discoteque.Business.IServices;
using Discoteque.Data;
using Discoteque.Data.Models;


namespace Discoteque.Business.Services;


public class TourService : ITourService
{
    private IUnitOfWork _unitOfWork;

    public TourService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public async Task<Tour> CreateTour(Tour tour)
    {
        var newTour = new Tour
        {
            Name =tour.Name,
            ArtistId = tour.ArtistId,
            City = tour.City,
            Date = tour.Date,
            Tickets = tour.Tickets,
          
        };

        await _unitOfWork.TourRepository.AddAsync(newTour);
        await _unitOfWork.SaveAsync();
        return newTour;
    }

  
    public async Task<IEnumerable<Tour>> GetToursAsync(bool areReferencesLoaded)
    {
        IEnumerable<Tour> tours;
        if (areReferencesLoaded)
        {
           tours = await _unitOfWork.TourRepository.GetAllAsync(null, x => x.OrderBy(x => x.Id), new Tour().GetType().Name);
        }
        else
        {
            tours = await _unitOfWork.TourRepository.GetAllAsync();
        }

        return tours;
    }

    public async Task<Tour> GetById(int id)
    {
        var tour = await _unitOfWork.TourRepository.FindAsync(id);
        return tour;
    }

    
    public async Task<Tour> UpdateTour(Tour tour)
    {
        await _unitOfWork.TourRepository.Update(tour);
        await _unitOfWork.SaveAsync();
        return tour;
    }
}

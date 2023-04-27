namespace WebApi.Services;
using AutoMapper;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Users;
using BCrypt.Net;

public interface IUserService
{
    IEnumerable<User> GetAll();
    User GetById(int id);
    User GetByGoogleUID(string uid);
    void Create(CreateUser model);
    void Update(int id, UpdateUser model);
    void Delete(int id);
}

public class UserService : IUserService
{
    private DataContext _context;
    private readonly IMapper _mapper;

    public UserService(
        DataContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public IEnumerable<User> GetAll()
    {
        return _context.Users;
    }

    public User GetById(int id)
    {
        return _getUser(id);
    }

    public User GetByGoogleUID(string uid)
    {
        return _getByGoogleUID(uid);
    }

    public void Create(CreateUser model)
    {
        // map model to new user object
        var user = _mapper.Map<User>(model);

        user.GoogleUID = model.GoogleUID;
        
        // save user
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public void Update(int id, UpdateUser model)
    {
        var user = _getUser(id);
        // copy model to user and save
        _mapper.Map(model, user);
        _context.Users.Update(user);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var user = _getUser(id);
        _context.Users.Remove(user);
        _context.SaveChanges();
    }

    // helper methods
    private User _getUser(int id)
    {
        var user = _context.Users.Find(id);
        if (user == null) throw new KeyNotFoundException("User not found");
        return user;
    }
    private User _getByGoogleUID(string uid)
    {
        var user = _context.Users.FirstOrDefault(u => u.GoogleUID == uid);
        if (user == null) throw new KeyNotFoundException("Unable to find user my Google UID");
        return user;
    }
}
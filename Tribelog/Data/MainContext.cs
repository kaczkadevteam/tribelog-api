using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tribelog.Data;

public class MainContext(DbContextOptions<MainContext> options) : IdentityDbContext(options) { }

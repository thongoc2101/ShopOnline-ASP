using System.Collections.Generic;
using Data.Infrastructure;
using Data.Repositories;
using Model.Models;

namespace Service
{
    public interface IPostService
    {
        void Add(Post post); // them

        void Update(Post post); // sua

        void Delete(int id); // xoa

        IEnumerable<Post> GetAll(); // tim kiem

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow); // phan trang

        Post GetById(int id); // tim kiem ID

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChange();
    }
    public class PostService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            // trong bang post có khoá ngoại qua bảng postCategory. Nên khi select all thì sẽ all cả 2 bảng lun
            return _postRepository.GetAll(new string[] {"PostCategory"});
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            // TODO: select all post by tag
            return _postRepository.GetMultiPaging(x=>x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x=>x.Status, out totalRow, page, pageSize);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }
    }
}

import 'package:team_track_app/core/resources/responce_state.dart';
import 'package:team_track_app/core/usecase/usecase.dart';
import 'package:team_track_app/domain/entities/emploee.dart';
import 'package:team_track_app/domain/repository/employee_repository.dart';

class EmployeesUseCase implements UseCase<Employee, int> {
  final EmployeeRepository _employeeRepository;
  EmployeesUseCase(this._employeeRepository);

  @override
  Future<ResponceState<List<Employee>>> getAll() {
    return _employeeRepository.getAllEmployees();
  }

  @override
  Future<ResponceState<Employee>> getOneById(int id) {
    return _employeeRepository.getEmployeById(id);
  }

  @override
  Future<ResponceState<List<Employee>>> create(Employee newItem) {
    return _employeeRepository.createEmployee(newItem);
  }

  @override
  Future<ResponceState<List<Employee>>> delete(int id) {
    return _employeeRepository.deleteEmployee(id);
  }

  @override
  Future<ResponceState<Employee>> update(Employee updatedEmployee) {
    return _employeeRepository.updateEmployee(updatedEmployee);
  }
}
